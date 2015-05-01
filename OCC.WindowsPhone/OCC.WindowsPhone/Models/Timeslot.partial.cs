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
namespace OCC.WindowsPhone.OrlandoCodeCampService
{
    public partial class Timeslot
    {
        public string Period
        {
            get
            {
                return string.Format("{0} - {1}", StartTime.GetValueOrDefault().ToShortTimeString(), EndTime.GetValueOrDefault().ToShortTimeString());
            }
        }
        public string ShortPeriod
        {
            get
            {
                return string.Format("{0} - {1}", StartTime.GetValueOrDefault().ToString("h:mm"), EndTime.GetValueOrDefault().ToString("h:mm"));
            }
        }
        public bool IsKeynotePeriod
        {
            get { return Name.ToLower().Contains("keynote"); }
        }
        public bool IsLunchPeriod
        {
            get
            {
                return Name.ToLower().Contains("lunch");
            }
        }
        public bool IsClosingPeriod
        {
            get
            {
                return Name.ToLower().Contains("closing");
            }
        }
    }
}
