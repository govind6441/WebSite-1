﻿#region License, Terms and Author(s)
//
// Orlando Code Camp for Windows Phone 7
// Copyright (c) 2012 Orlando .Net User Group. All rights reserved.
//
//  Author(s):
//
//      Brian Mishler, http://www.qualitydata.com
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion
using System;
using System.Globalization;
using System.Windows.Data;
using OCC.WindowsPhone.Common;

namespace OCC.WindowsPhone.ValueConverters
{

    public class RelativeUrlValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // if missing value then return empty string unless parameter has been provided as a default
            if ((! (value is string) || string.IsNullOrEmpty((string)value)))
            {
                return parameter ?? "";
            }
            var url = (string)value;
            var newUrl = url.Replace("../../", Constants.WebsiteUrl);
            return newUrl;

        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
