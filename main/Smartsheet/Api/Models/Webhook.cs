﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed To in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartsheet.Api.Models
{
	/// <summary>
	/// Represents the webhook object. </summary>
	/// <seealso href="http://smartsheet-platform.github.io/api-docs/#webhook-object">Webhook Object Help</seealso>
	public class Webhook : NamedModel
	{
		/// <summary>
		/// API Client Id corresponding to third-party app that created the Webhook. Read-only. Only present if webhook was created by third-party app.
		/// </summary>
		private string apiClientId;

		/// <summary>
		/// API Client Name corresponding to third-party app that created the Webhook. Read-only. Only present if webhook was created by third-party app.
		/// </summary>
		private string apiClientName;

		/// <summary>
		/// Scope of the subscription. Currently, the only supported value is “sheet”. Specified when a webhook is created and cannot be changed.
		/// </summary>
		private string scope;

		/// <summary>
		/// ID of the object that is subscribed to. Specified when a webhook is created and cannot be changed..
		/// </summary>
		private long? scopeObjectId;

		/// <summary>
		/// Array of the events that are subscribed to. Currently, must be an array of size 1 that contains the string 
		/// value “*.*”, which means “all objects” and “all events”.
		/// </summary>
		private IList<string> events;

		/// <summary>
		/// HTTPS URL where callbacks will be sent.
		/// </summary>
		private string callbackUrl;

		/// <summary>
		/// Shared secret for this webhook, randomly generated by Smartsheet. Read-only. See Authenticating Callbacks for 
		/// details about how this value can be used.
		/// </summary>
		private string sharedSecret;

		/// <summary>
		/// Flag indicating whether the Webhook is on (true) or off (false)
		/// </summary>
		private bool? enabled;

		/// <summary>
		/// Webhook status. Read-only. See Webhook Status for list of possible values.
		/// </summary>
		private WebhookStatus? status;

		/// <summary>
		/// Details about the reason the Webhook was disabled. Read-only. Only present when enabled=false
		/// </summary>
		private string disabledDetails;

		/// <summary>
		/// Webhook version. Currently, the only supported value is 1. This attribute is intended to ensure backward compatibility as new 
		/// webhook functionality is released. For example, a webhook with a version of 1 is guaranteed to always be sent callback objects 
		/// that are compatible with the version 1 release of webhooks.
		/// </summary>
		private int? version;

		/// <summary>
		/// Useful statistics for this webhook. Will only be returned once this webhook has performed a callback attempt. Read-only.
		/// </summary>
		private WebhookStats stats;

		/// <summary>
		/// Time of creation. Read-only.
		/// </summary>
		private DateTime? createdAt;

		/// <summary>
		/// Time of last modification. Read-only.
		/// </summary>
		private DateTime? modifiedAt;

		/// <summary>
		/// Get the API Client Id corresponding to third-party app that created the Webhook.
		/// </summary>
		/// <returns> the Client Id </returns>
		public virtual string ApiClientId
		{
			get
			{
				return apiClientId;
			}
			set
			{
				this.apiClientId = value;
			}
		}

		/// <summary>
		/// Get the API Client Name corresponding to third-party app that created the Webhook.
		/// </summary>
		/// <returns> the Client Name </returns>
		public virtual string ApiClientName
		{
			get
			{
				return apiClientName;
			}
			set
			{
				this.apiClientName = value;
			}
		}

		/// <summary>
		/// Get the Scope of the subscription.
		/// </summary>
		/// <returns> the Scope </returns>
		public virtual string Scope
		{
			get
			{
				return scope;
			}
			set
			{
				this.scope = value;
			}
		}

		/// <summary>
		/// Get the ID of the object that is subscribed to.
		/// </summary>
		/// <returns> the ScopeObjectId </returns>
		public virtual long? ScopeObjectId
		{
			get
			{
				return scopeObjectId;
			}
			set
			{
				this.scopeObjectId = value;
			}
		}

		/// <summary>
		/// Get the Array of the events that are subscribed to.
		/// </summary>
		/// <returns> the string array </returns>
		public virtual IList<string> Events
		{
			get
			{
				return events;
			}
			set
			{
				this.events = value;
			}
		}

		/// <summary>
		/// Get the HTTPS URL where callbacks will be sent.
		/// </summary>
		/// <returns> the URL </returns>
		public virtual string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set
			{
				this.callbackUrl = value;
			}
		}

		/// <summary>
		/// Get the Shared secret for this webhook, randomly generated by Smartsheet.
		/// </summary>
		/// <returns> the shared secret </returns>
		public virtual string SharedSecret
		{
			get
			{
				return sharedSecret;
			}
			set
			{
				this.sharedSecret = value;
			}
		}

		/// <summary>
		/// Get the Flag indicating whether the Webhook is on (true) or off (false).
		/// </summary>
		/// <returns> the enabled flag </returns>
		public virtual bool? Enabled
		{
			get
			{
				return enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		/// <summary>
		/// Get the Webhook status.
		/// </summary>
		/// <returns> the status </returns>
		public virtual WebhookStatus? Status
		{
			get
			{
				return status;
			}
			set
			{
				this.status = value;
			}
		}

		/// <summary>
		/// Get the details about the reason the Webhook was disabled.
		/// </summary>
		/// <returns> the details </returns>
		public virtual string DisabledDetails
		{
			get
			{
				return disabledDetails;
			}
			set
			{
				this.disabledDetails = value;
			}
		}

		/// <summary>
		/// Get the webhook version.
		/// </summary>
		/// <returns> the version </returns>
		public virtual int? Version
		{
			get
			{
				return version;
			}
			set
			{
				this.version = value;
			}
		}

		/// <summary>
		/// Get the statistics for this webhook.
		/// </summary>
		/// <returns> the WebhookStats </returns>
		public virtual WebhookStats Stats
		{
			get
			{
				return stats;
			}
			set
			{
				this.stats = value;
			}
		}

		/// <summary>
		/// Gets the Time that the webhook was created.
		/// </summary>
		/// <returns> the DateTime </returns>
		public virtual DateTime? CreatedAt
		{
			get
			{
				return createdAt;
			}
			set
			{
				this.createdAt = value;
			}
		}

		/// <summary>
		/// Gets the time that the webhook was modified.
		/// </summary>
		/// <returns> the DateTime </returns>
		public virtual DateTime? ModifiedAt
		{
			get
			{
				return modifiedAt;
			}
			set
			{
				this.modifiedAt = value;
			}
		}
	}
}
