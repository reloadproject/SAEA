﻿/****************************************************************************
*Copyright (c) 2018 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：Microsoft
*命名空间：SAEA.RPC.Common
*文件名： UniqueKeyHelper
*版本号： V3.6.2.1
*唯一标识：b0c33733-d06f-48e5-bcd1-7db71dd3f37a
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/5/16 16:43:33
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/5/16 16:43:33
*修改人： yswenli
*版本号： V3.6.2.1
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SAEA.RPC.Common
{
    /// <summary>
    /// 唯一值工具类
    /// </summary>
    public static class UniqueKeyHelper
    {
        static long sNo = long.MinValue;
        /// <summary>
        /// 获取下一个值
        /// </summary>
        /// <returns></returns>
        public static long Next()
        {
            if (Interlocked.Increment(ref sNo) > long.MaxValue - 10000)
            {
                sNo = 0;
            }
            return sNo;
        }
    }
}
