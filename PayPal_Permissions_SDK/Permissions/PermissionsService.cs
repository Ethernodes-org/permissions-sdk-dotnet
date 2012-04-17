/** 
 * Auto generated code
 */

using PayPal.Authentication;

namespace PayPal.Permissions {

	using PayPal;
	using PayPal.Util;
	using PayPal.Manager;
	using PayPal.Permissions.Model;

	public partial class PermissionsService :BasePayPalService{

		private static string serviceName = "Permissions";


		private static string serviceVersion"";


		 public PermissionsService() : base(serviceName)
		        {}
	/// <summary>
 /// Sets standard parameters common to all requests
 /// </summary>
		/**
		 *
		 */
		public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest RequestPermissionsRequest, string apiUsername) 
		{
			BasePayPalService service = new BasePayPalService(serviceName);
			string resp = service.call("RequestPermissions", RequestPermissionsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new RequestPermissionsResponse(util.parseNVPString(resp), "");
		}

		public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest RequestPermissionsRequest) 
		{
			return RequestPermissions(RequestPermissionsRequest, null);
		}
		/**
		 *
		 */
		public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest GetAccessTokenRequest, string apiUsername) 
		{
			BasePayPalService service = new BasePayPalService(serviceName);
			string resp = service.call("GetAccessToken", GetAccessTokenRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetAccessTokenResponse(util.parseNVPString(resp), "");
		}

		public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest GetAccessTokenRequest) 
		{
			return GetAccessToken(GetAccessTokenRequest, null);
		}
		/**
		 *
		 */
		public GetPermissionsResponse GetPermissions(GetPermissionsRequest GetPermissionsRequest, string apiUsername) 
		{
			BasePayPalService service = new BasePayPalService(serviceName);
			string resp = service.call("GetPermissions", GetPermissionsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetPermissionsResponse(util.parseNVPString(resp), "");
		}

		public GetPermissionsResponse GetPermissions(GetPermissionsRequest GetPermissionsRequest) 
		{
			return GetPermissions(GetPermissionsRequest, null);
		}
		/**
		 *
		 */
		public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest CancelPermissionsRequest, string apiUsername) 
		{
			BasePayPalService service = new BasePayPalService(serviceName);
			string resp = service.call("CancelPermissions", CancelPermissionsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new CancelPermissionsResponse(util.parseNVPString(resp), "");
		}

		public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest CancelPermissionsRequest) 
		{
			return CancelPermissions(CancelPermissionsRequest, null);
		}
		/**
		 *
		 */
		public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest GetBasicPersonalDataRequest, string apiUsername) 
		{
			BasePayPalService service = new BasePayPalService(serviceName);
			string resp = service.call("GetBasicPersonalData", GetBasicPersonalDataRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetBasicPersonalDataResponse(util.parseNVPString(resp), "");
		}

		public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest GetBasicPersonalDataRequest) 
		{
			return GetBasicPersonalData(GetBasicPersonalDataRequest, null);
		}
		/**
		 *
		 */
		public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest GetAdvancedPersonalDataRequest, string apiUsername) 
		{
			BasePayPalService service = new BasePayPalService(serviceName);
			string resp = service.call("GetAdvancedPersonalData", GetAdvancedPersonalDataRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetAdvancedPersonalDataResponse(util.parseNVPString(resp), "");
		}

		public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest GetAdvancedPersonalDataRequest) 
		{
			return GetAdvancedPersonalData(GetAdvancedPersonalDataRequest, null);
		}
	}
}

