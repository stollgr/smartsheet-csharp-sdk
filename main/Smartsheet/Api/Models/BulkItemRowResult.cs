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
	/// Represents the BulkItemRowResult object. </summary>
	/// <seealso href="http://smartsheet-platform.github.io/api-docs/?shell#partial-success">Partial Success</seealso>
	public class BulkItemRowResult
	{
		private int? resultCode;

		private string message;

		/// <summary>
		/// Row object(s) created or updated
		/// </summary>
		private IList<Row> result;

		/// <summary>
		/// Array of BulkItemFailure objects which represents the items that failed to be added or updated
		/// </summary>
		private IList<BulkItemFailure> failedItems;

		/// <summary>
		/// Gets the result Code.
		/// </summary>
		/// <returns> the result Code </returns>
		public virtual int? ResultCode
		{
			get
			{
				return resultCode;
			}
			set
			{
				this.resultCode = value;
			}
		}

		/// <summary>
		/// Gets the Message.
		/// </summary>
		/// <returns> the Message </returns>
		public virtual string Message
		{
			get
			{
				return message;
			}
			set
			{
				this.message = value;
			}
		}

		/// <summary>
		/// Row results created or updated.
		/// </summary>
		/// <returns> Array of Row objects </returns>
		public virtual IList<Row> Result
		{
			get
			{
				return result;
			}
			set
			{
				this.result = value;
			}
		}

		/// <summary>
		/// Array of BulkItemFailure objects which represents the items that failed to be added or updated. 
		/// </summary>
		/// <returns> the Description </returns>
		public virtual IList<BulkItemFailure> FailedItems
		{
			get
			{
				return failedItems;
			}
			set
			{
				this.failedItems = value;
			}
		}
	}
}
