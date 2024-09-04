using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dragon.Dance.Professional.Manage.RNDragonDanceProfessionalManage
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDragonDanceProfessionalManageModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDragonDanceProfessionalManageModule"/>.
        /// </summary>
        internal RNDragonDanceProfessionalManageModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDragonDanceProfessionalManage";
            }
        }
    }
}
