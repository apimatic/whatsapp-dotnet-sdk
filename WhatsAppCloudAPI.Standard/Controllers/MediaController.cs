// <copyright file="MediaController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace WhatsAppCloudAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using WhatsAppCloudAPI.Standard;
    using WhatsAppCloudAPI.Standard.Authentication;
    using WhatsAppCloudAPI.Standard.Http.Client;
    using WhatsAppCloudAPI.Standard.Http.Request;
    using WhatsAppCloudAPI.Standard.Http.Request.Configuration;
    using WhatsAppCloudAPI.Standard.Http.Response;
    using WhatsAppCloudAPI.Standard.Utilities;

    /// <summary>
    /// MediaController.
    /// </summary>
    public class MediaController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal MediaController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// This endpoint can be used for deleting a media object.
        /// </summary>
        /// <param name="mediaID">Required parameter: Media object ID from either uploading media endpoint or media message Webhooks.</param>
        /// <returns>Returns the Models.SuccessResponse response from the API call.</returns>
        public Models.SuccessResponse DeleteMedia(
                string mediaID)
        {
            Task<Models.SuccessResponse> t = this.DeleteMediaAsync(mediaID);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint can be used for deleting a media object.
        /// </summary>
        /// <param name="mediaID">Required parameter: Media object ID from either uploading media endpoint or media message Webhooks.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SuccessResponse response from the API call.</returns>
        public async Task<Models.SuccessResponse> DeleteMediaAsync(
                string mediaID,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/{Media-ID}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "Media-ID", mediaID },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.SuccessResponse>(response.Body);
        }

        /// <summary>
        /// To retrieve your media’s URL, make a request to this endpoint. Later, you can use this URL to download the media file.
        /// </summary>
        /// <param name="mediaID">Required parameter: Media object ID from either uploading media endpoint or media message Webhooks.</param>
        /// <returns>Returns the Models.RetrieveMediaURLResponse response from the API call.</returns>
        public Models.RetrieveMediaURLResponse RetrieveMediaURL(
                string mediaID)
        {
            Task<Models.RetrieveMediaURLResponse> t = this.RetrieveMediaURLAsync(mediaID);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// To retrieve your media’s URL, make a request to this endpoint. Later, you can use this URL to download the media file.
        /// </summary>
        /// <param name="mediaID">Required parameter: Media object ID from either uploading media endpoint or media message Webhooks.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RetrieveMediaURLResponse response from the API call.</returns>
        public async Task<Models.RetrieveMediaURLResponse> RetrieveMediaURLAsync(
                string mediaID,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/{Media-ID}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "Media-ID", mediaID },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.RetrieveMediaURLResponse>(response.Body);
        }

        /// <summary>
        /// Used to upload media. All media files sent through this endpoint are encrypted and persist for 30 days.
        /// </summary>
        /// <param name="phoneNumberID">Required parameter: Example: .</param>
        /// <param name="messagingProduct">Required parameter: Messaging service used for the request. In this case, use whatsapp..</param>
        /// <param name="file">Required parameter: Path to the file stored in your local directory. For example: "@/local/path/file.jpg"..</param>
        /// <param name="type">Required parameter: Type of media file being uploaded. See Supported Media Types for more information.    Supported options for images are: `image/jpeg`, `image/png`    Supported options for documents are: `text/plain`, `application/pdf`, `application/vnd.ms-powerpoint`, `application/msword`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`  Supported options for audio are: `audio/aac`, `audio/mp4`, `audio/mpeg`, `audio/amr`, `audio/ogg`, `audio/opus`  Supported options for video are: `video/mp4`, `video/3gp`  Supported options for stickers are: `image/webp`.</param>
        /// <returns>Returns the Models.UploadMedia response from the API call.</returns>
        public Models.UploadMedia UploadMedia(
                string phoneNumberID,
                string messagingProduct,
                string file,
                string type)
        {
            Task<Models.UploadMedia> t = this.UploadMediaAsync(phoneNumberID, messagingProduct, file, type);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Used to upload media. All media files sent through this endpoint are encrypted and persist for 30 days.
        /// </summary>
        /// <param name="phoneNumberID">Required parameter: Example: .</param>
        /// <param name="messagingProduct">Required parameter: Messaging service used for the request. In this case, use whatsapp..</param>
        /// <param name="file">Required parameter: Path to the file stored in your local directory. For example: "@/local/path/file.jpg"..</param>
        /// <param name="type">Required parameter: Type of media file being uploaded. See Supported Media Types for more information.    Supported options for images are: `image/jpeg`, `image/png`    Supported options for documents are: `text/plain`, `application/pdf`, `application/vnd.ms-powerpoint`, `application/msword`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`  Supported options for audio are: `audio/aac`, `audio/mp4`, `audio/mpeg`, `audio/amr`, `audio/ogg`, `audio/opus`  Supported options for video are: `video/mp4`, `video/3gp`  Supported options for stickers are: `image/webp`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UploadMedia response from the API call.</returns>
        public async Task<Models.UploadMedia> UploadMediaAsync(
                string phoneNumberID,
                string messagingProduct,
                string file,
                string type,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/{Phone-Number-ID}/media");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "Phone-Number-ID", phoneNumberID },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("messaging_product", messagingProduct),
                new KeyValuePair<string, object>("file", file),
                new KeyValuePair<string, object>("type", type),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.UploadMedia>(response.Body);
        }
    }
}