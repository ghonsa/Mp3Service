﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.Services;
using System.Data.Services.Providers;
using System.Data.Objects;
using System.Web.Hosting;
using Mp3Service;

namespace Mp3Service
{
    public class Mp3ServiceStreamProvider : IDataServiceStreamProvider, IDisposable
    {
        private string imageFilePath;
        private Mp3File cachedEntity;
        private MP3DataContainer context;

        private string tempFile;

        public Mp3ServiceStreamProvider(MP3DataContainer context)
        {
            this.context = context;

            // Get the physical path to the app_data directory used to store the image files.
            imageFilePath = HostingEnvironment.MapPath("~/App_Data/");

            // Create a temp file to store the new images during POST operations.
            tempFile = Path.GetTempFileName();
        }

        #region IDataServiceStreamProvider Members

        public void DeleteStream(object entity, DataServiceOperationContext operationContext)
        {
           
                throw new DataServiceException("Deleteion not supported");
        }

        public Stream GetReadStream(object entity, string etag, bool?
            checkETagForEquality, DataServiceOperationContext operationContext)
        {
            if (checkETagForEquality != null)
            {
                // This stream provider implementation does not support 
                // ETag headers for media resources. This means that we do not track 
                // concurrency for a media resource and last-in wins on updates.
                throw new DataServiceException(400,
                    "This sample service does not support the ETag header for a media resource.");
            }

            Mp3File mp3Inf = entity as Mp3File;
            if (mp3Inf == null)
            {
                throw new DataServiceException(500, "Internal Server Error.");
            }

            // Build the full path to the stored image file, which includes the entity key.
            string fullImageFilePath = mp3Inf.filePath;

            if (!File.Exists(fullImageFilePath))
            {
                throw new DataServiceException(500, "The mp3 could not be found.");
            }

            // Return a stream that contains the requested file.
            return new FileStream(fullImageFilePath, FileMode.Open);
        }

        public Uri GetReadStreamUri(object entity, DataServiceOperationContext operationContext)
        {
            // Allow the runtime set the URI of the Media Resource.
            return null;
        }

        public string GetStreamContentType(object entity, DataServiceOperationContext operationContext)
        {
            // Get the PhotoInfo entity instance.
            Mp3File mp3Inf = entity as Mp3File;
            if (mp3Inf == null)
            {
                throw new DataServiceException(500, "Internal Server Error.");
            }

            return "MP3File";
        }

        public string GetStreamETag(object entity, DataServiceOperationContext operationContext)
        {
            // This sample provider does not support the eTag header with media resources.
            // This means that we do not track concurrency for a media resource 
            // and last-in wins on updates.
            return null;
        }

        public Stream GetWriteStream(object entity, string etag, bool?
            checkETagForEquality, DataServiceOperationContext operationContext)
        {
            if (checkETagForEquality != null)
            {
                // This stream provider implementation does not support ETags associated with BLOBs.
                // This means that we do not track concurrency for a media resource 
                // and last-in wins on updates.
                throw new DataServiceException(400, "This demo does not support ETags associated with BLOBs");
            }

            Mp3File mp3Inf = entity as Mp3File;

            if (mp3Inf == null)
            {
                throw new DataServiceException(500, "Internal Server Error: "
                    + "the Media Link Entry could not be determined.");
            }

            // Handle the POST request.
            if (operationContext.RequestMethod == "POST")
            {
                // Set the file name from the Slug header; if we don't have a 
                // Slug header, just set a temporary name which is overwritten 
                // by the subsequent MERGE request from the client. 
                mp3Inf.filePath = operationContext.RequestHeaders["Slug"] ?? "newFile";

                // Set the required DateTime values.
                

                // Set the content type, which cannot be null.
               // mp3Inf.ContentType = operationContext.RequestHeaders["Content-Type"];

                // Cache the current entity to enable us to both create a key based storage file name 
                // and to maintain transactional integrity in the disposer; we do this only for a POST request.
                cachedEntity = mp3Inf;

                return new FileStream(tempFile, FileMode.Open);
            }
            // Handle the PUT request
            else
            {
                // Return a stream to write to an existing file.
                return new FileStream( mp3Inf.filePath,
                    FileMode.Open, FileAccess.Write);
            }
        }

        public string ResolveType(string entitySetName, DataServiceOperationContext operationContext)
        {
            // We should only be handling PhotoInfo types.
            if (entitySetName == "PhotoInfo")
            {
                return "PhotoService.PhotoInfo";
            }
            else
            {
                // This will raise an DataServiceException.
                return null;
            }
        }

        public int StreamBufferSize
        {
            // Use a buffer size of 64K bytes.
            get { return 64000; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            // If we have a cached entity, it must be a POST request.
            if (cachedEntity != null)
            {
                // Get the new entity from the Entity Framework object state manager.
                ObjectStateEntry entry = this.context.ObjectStateManager.GetObjectStateEntry(cachedEntity);

                if (entry.State == System.Data.EntityState.Unchanged)
                {
                    // Since the entity was created successfully, move the temp file into the 
                    // storage directory and rename the file based on the new entity key.
                    File.Move(tempFile,  cachedEntity.filePath);

                    // Delete the temp file.
                    File.Delete(tempFile);
                }
                else
                {
                    // A problem must have occurred when saving the entity to the database, 
                    // so we should delete the entity and temp file.
                    context.DeleteObject(cachedEntity);
                    File.Delete(tempFile);

                    throw new DataServiceException("An error occurred. The MP3 could not be saved.");
                }
            }
        }
        #endregion
    }
 }