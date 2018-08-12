﻿using CodeStack.VPages.Sw.Attributes;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Xarial.VPages.Framework.Attributes;
using System.ComponentModel;

namespace SwVPagesSample
{
    [PropertyManagerPageOptions(swPropertyManagerPageOptions_e.swPropertyManagerOptions_OkayButton
        | swPropertyManagerPageOptions_e.swPropertyManagerOptions_CancelButton 
        | swPropertyManagerPageOptions_e.swPropertyManagerOptions_WhatsNew)]
    public class DataModel
    {
        [PropertyManagerPageControlOptions(backgroundColor: KnownColor.Green, textColor: KnownColor.Yellow)]
        public string Text1 { get; set; }

        [PropertyManagerPageControlAttribution(swControlBitmapLabelType_e.swBitmapLabel_Depth)]
        public string Text2 { get; set; }

        public int Number1 { get; set; }

        public double FloatingNumber1 { get; set; }

        [Description("Sample Toggle")]
        [DisplayName("CheckBox")]
        public bool Toggle { get; private set; }

        public DataGroup Group { get; set; }

        [PropertyManagerPageSelectionBox(swSelectType_e.swSelDATUMPLANES, swSelectType_e.swSelFACES, swSelectType_e.swSelEDGES)]
        [PropertyManagerPageSelectionBoxStyle(height: 50, selColor: KnownColor.Yellow)]
        public List<SolidWorks.Interop.sldworks.IEntity> Selection { get; set; }
    }

    public class DataGroup
    {
        public string Text3 { get; set; }
    }
}
