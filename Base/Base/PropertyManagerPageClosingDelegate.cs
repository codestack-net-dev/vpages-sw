﻿//**********************
//SwEx.PMPage - data driven framework for SOLIDWORKS Property Manager Pages
//Copyright(C) 2019 www.codestack.net
//License: https://github.com/codestackdev/swex-pmpage/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/pmp/
//**********************

using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeStack.SwEx.PMPage.Base
{
    /// <summary>
    /// Delegate for handling the parameters of property manager page closing event
    /// </summary>
    /// <param name="reason">Reason of closing as defined in <see href="http://help.solidworks.com/2016/english/api/swconst/solidworks.interop.swconst~solidworks.interop.swconst.swpropertymanagerpageclosereasons_e.html">swPropertyManagerPageCloseReasons_e Enumeration</see></param>
    /// <param name="arg">Closing argument. Use this argument to cancel closing if needed</param>
    public delegate void PropertyManagerPageClosingDelegate(swPropertyManagerPageCloseReasons_e reason, ClosingArg arg);
}
