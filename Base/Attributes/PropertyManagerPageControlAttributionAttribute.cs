﻿//**********************
//vPages for SOLIDWORKS
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/vpages-sw/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/vpages/
//**********************

using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Base;

namespace CodeStack.VPages.Sw.Attributes
{
    public class PropertyManagerPageControlAttributionAttribute : Attribute, IAttribute
    {
        public swControlBitmapLabelType_e StandardIcon { get; private set; } = 0;

        public PropertyManagerPageControlAttributionAttribute(swControlBitmapLabelType_e standardIcon)
        {
            StandardIcon = standardIcon;
        }
    }
}
