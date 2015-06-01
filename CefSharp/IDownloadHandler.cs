﻿// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace CefSharp
{
    public interface IDownloadHandler
    {
        /// <summary>
        /// Called before a download begins.
        /// </summary>
        /// <param name="browser">The browser instance</param>
        /// <param name="downloadItem">Represents the file being downloaded.</param>
        /// <param name="downloadPath">Path where the file will be saved if <see cref="showDialog"/> is False.</param>
        /// <param name="showDialog">Display a dialog allowing the user to specify a custom path and filename.</param>
        /// <returns>Return True to continue the download otherwise return False to cancel the download</returns>
        bool OnBeforeDownload(IBrowser browser, DownloadItem downloadItem, out string downloadPath, out bool showDialog);

        /// <summary>
        /// Called when a download's status or progress information has been updated. This may be called multiple times before and after <see cref="OnBeforeDownload"/>.
        /// </summary>
        /// <param name="browser">The browser instance</param>
        /// <param name="downloadItem">Represents the file being downloaded.</param>
        /// <param name="callback">The callback used to Cancel/Pause/Resume the process</param>
        /// <returns>Return True to cancel, otherwise False to allow the download to continue.</returns>
        void OnDownloadUpdated(IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback);
    }
}
