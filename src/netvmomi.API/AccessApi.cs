using netvmomi.Client;
using netvmomi.Model;
using RestSharp;
using System.Collections.Generic;

namespace netvmomi.API {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccess {
        /// <summary>
        /// ConsoleCLI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void GetApplianceAccessConsoleCLI();
        /// <summary>
        /// ConsoleCLI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessConsolecliPut(ConsoleCLIDisableRequest body);
        /// <summary>
        /// DCUI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessDcuiGet();
        /// <summary>
        /// DCUI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessDcuiPut(DCUIDisableRequest body);
        /// <summary>
        /// Shell TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessShellGet();
        /// <summary>
        /// Shell-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessShellPut(ShellDisableRequest body);
        /// <summary>
        /// SSH TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void ApplianceAccessSshGet();
        /// <summary>
        /// SSH-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApplianceAccessSshPut(SSHDisableRequest body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccessAPI : IAccess {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessAPI"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccessAPI(ApiClient apiClient = null) {
            if (apiClient == null) // use the default one in Configuration
{
                ApiClient = Configuration.DefaultApiClient;
            } else {
                ApiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessAPI"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessAPI(string basePath) {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath) {
            ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath) {
            return ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// ConsoleCLI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void GetApplianceAccessConsoleCLI() {

            string path = "/appliance/access/consolecli";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling GetApplianceAccessConsoleCLI: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling GetApplianceAccessConsoleCLI: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// ConsoleCLI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessConsolecliPut(ConsoleCLIDisableRequest body) {

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessConsolecliPut");
            }

            string path = "/appliance/access/consolecli";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessConsolecliPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessConsolecliPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// DCUI TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessDcuiGet() {

            string path = "/appliance/access/dcui";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("appliation/json"));

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// DCUI-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessDcuiPut(DCUIDisableRequest body) {

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessDcuiPut");
            }

            string path = "/appliance/access/dcui";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessDcuiPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Shell TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessShellGet() {

            string path = "/appliance/access/shell";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// Shell-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessShellPut(ShellDisableRequest body) {

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessShellPut");
            }

            string path = "/appliance/access/shell";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessShellPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// SSH TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <returns></returns>            
        public void ApplianceAccessSshGet() {

            string path = "/appliance/access/ssh";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshGet: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshGet: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

        /// <summary>
        /// SSH-disable TODO: Add Description
        /// </summary>
        /// <param name="contentType"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ApplianceAccessSshPut(SSHDisableRequest body) {

            // verify the required parameter 'body' is set
            if (body == null) {
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplianceAccessSshPut");
            }

            string path = "/appliance/access/ssh";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            headerParams.Add("Content-Type", ApiClient.ParameterToString("application/json"));

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "auth" };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshPut: " + response.Content, response.Content);
            } else if (response.StatusCode == 0) {
                throw new ApiException((int)response.StatusCode, "Error calling ApplianceAccessSshPut: " + response.ErrorMessage, response.ErrorMessage);
            }

            return;
        }

    }
}
