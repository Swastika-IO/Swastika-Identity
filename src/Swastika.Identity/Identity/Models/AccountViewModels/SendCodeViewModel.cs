﻿// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the GNU General Public License v3.0 license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Swastika.Identity.Models.AccountViewModels
{
    public class SendCodeViewModel
    {
        /// <summary>
        /// Gets or sets the selected provider.
        /// </summary>
        /// <value>
        /// The selected provider.
        /// </value>
        public string SelectedProvider { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        /// <value>
        /// The providers.
        /// </value>
        public ICollection<SelectListItem> Providers { get; set; }

        /// <summary>
        /// Gets or sets the return URL.
        /// </summary>
        /// <value>
        /// The return URL.
        /// </value>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether {CC2D43FA-BBC4-448A-9D0B-7B57ADF2655C}[remember me].
        /// </summary>
        /// <value>
        /// {D255958A-8513-4226-94B9-080D98F904A1}  <c>true</c> if [remember me]; otherwise, <c>false</c>.
        /// </value>
        public bool RememberMe { get; set; }
    }
}