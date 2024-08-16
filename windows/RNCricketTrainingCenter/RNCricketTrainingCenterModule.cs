using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cricket.Training.Center.RNCricketTrainingCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCricketTrainingCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCricketTrainingCenterModule"/>.
        /// </summary>
        internal RNCricketTrainingCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCricketTrainingCenter";
            }
        }
    }
}
