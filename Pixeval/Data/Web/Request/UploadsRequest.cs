﻿// Pixeval - A Strong, Fast and Flexible Pixiv Client
// Copyright (C) 2019 Dylech30th
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using Refit;

namespace Pixeval.Data.Web.Request
{
    public class UploadsRequest
    {
        [AliasAs("page")]
        public int Page { get; set; }

        [AliasAs("publicity")]
        public string Publicity { get; set; } = "public";

        [AliasAs("per_page")]
        public int PerPage { get; set; } = 30;

        [AliasAs("image_sizes")]
        public string ImageSizes { get; set; } = "px_128x128,px_480mw,large";

        [AliasAs("include_stats")]
        public bool IncludeStats { get; set; } = true;
    }
}