﻿//**********************
//SwEx.PMPage - data driven framework for SOLIDWORKS Property Manager Pages
//Copyright(C) 2019 www.codestack.net
//License: https://github.com/codestackdev/swex-pmpage/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using CodeStack.SwEx.PMPage.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xarial.VPages.Framework.Attributes;
using Xarial.VPages.Framework.Constructors;
using Xarial.VPages.Framework.Base;
using SolidWorks.Interop.swconst;
using CodeStack.SwEx.PMPage.Attributes;
using System.Drawing;
using SolidWorks.Interop.sldworks;
using CodeStack.SwEx.Common.Icons;

namespace CodeStack.SwEx.PMPage.Constructors
{
    [DefaultType(typeof(bool))]
    internal class PropertyManagerPageCheckBoxConstructor<THandler>
        : PropertyManagerPageControlConstructor<THandler, PropertyManagerPageCheckBoxEx, IPropertyManagerPageCheckbox>
        where THandler : PropertyManagerPageHandlerEx, new()
    {
        public PropertyManagerPageCheckBoxConstructor(ISldWorks app, IconsConverter iconsConv) 
            : base(app, swPropertyManagerPageControlType_e.swControlType_Checkbox, iconsConv)
        {
        }

        protected override PropertyManagerPageCheckBoxEx CreateControl(
            IPropertyManagerPageCheckbox swCtrl, IAttributeSet atts, THandler handler, short height)
        {
            swCtrl.Caption = atts.Name;

            return new PropertyManagerPageCheckBoxEx(atts.Id, atts.Tag, swCtrl, handler);
        }
    }
}
