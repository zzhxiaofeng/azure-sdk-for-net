// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Network;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// networks your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157182.aspx for
    /// more information)
    /// </summary>
    public partial class VirtualNetworkManagementClient : ServiceClient<VirtualNetworkManagementClient>, Microsoft.WindowsAzure.Management.Network.IVirtualNetworkManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all SQL requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IClientRootCertificateOperations _clientRootCertificates;
        
        public virtual IClientRootCertificateOperations ClientRootCertificates
        {
            get { return this._clientRootCertificates; }
        }
        
        private IGatewayOperations _gateways;
        
        public virtual IGatewayOperations Gateways
        {
            get { return this._gateways; }
        }
        
        private INetworkOperations _networks;
        
        public virtual INetworkOperations Networks
        {
            get { return this._networks; }
        }
        
        private IReservedIPOperations _reservedIPs;
        
        public virtual IReservedIPOperations ReservedIPs
        {
            get { return this._reservedIPs; }
        }
        
        private IStaticIPOperations _staticIPs;
        
        public virtual IStaticIPOperations StaticIPs
        {
            get { return this._staticIPs; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkManagementClient
        /// class.
        /// </summary>
        private VirtualNetworkManagementClient()
            : base()
        {
            this._clientRootCertificates = new ClientRootCertificateOperations(this);
            this._gateways = new GatewayOperations(this);
            this._networks = new NetworkOperations(this);
            this._reservedIPs = new ReservedIPOperations(this);
            this._staticIPs = new StaticIPOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </param>
        /// <param name='baseUri'>
        /// The URI used as the base for all SQL requests.
        /// </param>
        public VirtualNetworkManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </param>
        public VirtualNetworkManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='requestId'>
        /// The request ID for the request you wish to track. The request ID is
        /// returned in the x-ms-request-id response header for every request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Network.Models.VirtualNetworkOperationStatusResponse> GetOperationStatusAsync(string requestId, CancellationToken cancellationToken)
        {
            // Validate
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("requestId", requestId);
                Tracing.Enter(invocationId, this, "GetOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = new Uri(this.BaseUri, "/").AbsoluteUri + this.Credentials.SubscriptionId + "/operations/" + requestId;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-11-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    VirtualNetworkOperationStatusResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new VirtualNetworkOperationStatusResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement operationElement = responseDoc.Element(XName.Get("Operation", "http://schemas.microsoft.com/windowsazure"));
                    if (operationElement != null)
                    {
                        XElement idElement = operationElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                        if (idElement != null)
                        {
                            string idInstance = idElement.Value;
                            result.Id = idInstance;
                        }
                        
                        XElement statusElement = operationElement.Element(XName.Get("Status", "http://schemas.microsoft.com/windowsazure"));
                        if (statusElement != null)
                        {
                            OperationStatus statusInstance = (OperationStatus)Enum.Parse(typeof(OperationStatus), statusElement.Value, false);
                            result.Status = statusInstance;
                        }
                        
                        XElement httpStatusCodeElement = operationElement.Element(XName.Get("HttpStatusCode", "http://schemas.microsoft.com/windowsazure"));
                        if (httpStatusCodeElement != null)
                        {
                            HttpStatusCode httpStatusCodeInstance = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), httpStatusCodeElement.Value, false);
                            result.HttpStatusCode = httpStatusCodeInstance;
                        }
                        
                        XElement errorElement = operationElement.Element(XName.Get("Error", "http://schemas.microsoft.com/windowsazure"));
                        if (errorElement != null)
                        {
                            VirtualNetworkOperationStatusResponse.ErrorDetails errorInstance = new VirtualNetworkOperationStatusResponse.ErrorDetails();
                            result.Error = errorInstance;
                            
                            XElement codeElement = errorElement.Element(XName.Get("Code", "http://schemas.microsoft.com/windowsazure"));
                            if (codeElement != null)
                            {
                                string codeInstance = codeElement.Value;
                                errorInstance.Code = codeInstance;
                            }
                            
                            XElement messageElement = errorElement.Element(XName.Get("Message", "http://schemas.microsoft.com/windowsazure"));
                            if (messageElement != null)
                            {
                                string messageInstance = messageElement.Value;
                                errorInstance.Message = messageInstance;
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Parse enum values for type LocalNetworkConnectionType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static LocalNetworkConnectionType ParseLocalNetworkConnectionType(string value)
        {
            if (value == "IPsec")
            {
                return LocalNetworkConnectionType.IPSecurity;
            }
            if (value == "Dedicated")
            {
                return LocalNetworkConnectionType.Dedicated;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type LocalNetworkConnectionType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string LocalNetworkConnectionTypeToString(LocalNetworkConnectionType value)
        {
            if (value == LocalNetworkConnectionType.IPSecurity)
            {
                return "IPsec";
            }
            if (value == LocalNetworkConnectionType.Dedicated)
            {
                return "Dedicated";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
