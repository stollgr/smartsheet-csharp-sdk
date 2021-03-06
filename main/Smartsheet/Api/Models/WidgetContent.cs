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
	public class WidgetContent
	{
		/// <summary>
		/// Represents the CellLinkWidgetContent object.</summary>
		/// <seealso href="http://smartsheet-platform.github.io/api-docs/#celllinkwidgetcontent-object">CellLinkWidge Object Help</seealso>		
		private Link hyperlink;
		private IList<CellDataItem> cellData;
		private IList<Column> column;

		/// <summary>
		/// Represents the RichTextWidgetContent object.</summary>
		/// <seealso href="http://smartsheet-platform.github.io/api-docs/#richtextwidgetcontent-object">RichTextWidget Object Help</seealso>		
		private string html;

		/// <summary>
		/// Represents the ShortcutWidgetContent object.</summary>
		/// <seealso href="http://smartsheet-platform.github.io/api-docs/#shortcutwidgetcontent-object">ShortcutWidgetContent Object Help</seealso>		
		private IList<ShortcutDataItem> shortcutData;

		/// <summary>
		/// Represents the ReportWidgetContent object.</summary>
		/// <seealso href="http://smartsheet-platform.github.io/api-docs/#reportwidgetcontent-object">ReportWidgetContent Object Help</seealso>	
		private string htmlContent;

		/// <summary>
		/// Represents the ImageWidgetContent object.</summary>
		/// <seealso href="http://smartsheet-platform.github.io/api-docs/#imagewidgetcontent-object">ImageWidgetContent  Object Help</seealso>	
		private string privateId;
		private int? height;
		private int? width;
		private string fileName;
		private string format;

		/// <summary>
		/// The widget has when clicked attribute set to that hyperlink (if present and non-null).
		/// </summary>
		/// <returns> the Link </returns>
		public virtual Link Hyperlink
		{
			get
			{
				return hyperlink;
			}
			set
			{
				this.hyperlink = value;
			}
		}

		/// <summary>
		/// Array of cellDataItem objects.
		/// </summary>
		/// <returns> the array </returns>
		public virtual IList<CellDataItem> CellData
		{
			get
			{
				return cellData;
			}
			set
			{
				this.cellData = value;
			}
		}

		/// <summary>
		/// Array of Column objects.
		/// </summary>
		/// <returns> the array </returns>
		public virtual IList<Column> Column
		{
			get
			{
				return column;
			}
			set
			{
				this.column = value;
			}
		}

		/// <summary>
		/// The widget content as HTML.
		/// </summary>
		/// <returns> the HTML string </returns>
		public virtual string Html
		{
			get
			{
				return html;
			}
			set
			{
				this.html = value;
			}
		}

		/// <summary>
		/// An array of ShortcutDataItem objects.
		/// </summary>
		/// <returns> the array </returns>
		public virtual IList<ShortcutDataItem> ShortcutData
		{
			get
			{
				return shortcutData;
			}
			set
			{
				this.shortcutData = value;
			}
		}

		/// <summary>
		/// HTML snippet to render Report.
		/// </summary>
		/// <returns> the HTML string </returns>
		public virtual string HtmlContent
		{
			get
			{
				return htmlContent;
			}
			set
			{
				this.htmlContent = value;
			}
		}

		/// <summary>
		/// The image private ID.
		/// </summary>
		/// <returns> the ID </returns>
		public virtual string PrivateId
		{
			get
			{
				return privateId;
			}
			set
			{
				this.privateId = value;
			}
		}

		/// <summary>
		/// Original height of the image in pixels.
		/// </summary>
		/// <returns> the height </returns>
		public virtual int? Height
		{
			get
			{
				return height;
			}
			set
			{
				this.height = value;
			}
		}

		/// <summary>
		/// Original width of the image in pixels.
		/// </summary>
		/// <returns> the width </returns>
		public virtual int? Width
		{
			get
			{
				return width;
			}
			set
			{
				this.width = value;
			}
		}

		/// <summary>
		/// Name of the image file.
		/// </summary>
		/// <returns> the name </returns>
		public virtual string FileName
		{
			get
			{
				return fileName;
			}
			set
			{
				this.fileName = value;
			}
		}

		/// <summary>
		/// The formatDescriptor for the image file.
		/// </summary>
		/// <returns> the formatDescriptor </returns>
		public virtual string Format
		{
			get
			{
				return format;
			}
			set
			{
				this.format = value;
			}
		}	
	}
}
