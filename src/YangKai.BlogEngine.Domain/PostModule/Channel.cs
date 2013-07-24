﻿using System;
using System.Collections.Generic;
using AtomLab.Core;

namespace YangKai.BlogEngine.Domain
{
    /// <summary>
    /// 频道信息.
    /// </summary>
    public class Channel : Entity
    {
        /// <summary>
        /// 主键.
        /// </summary>
        public Guid ChannelId { get; set; }

        /// <summary>
        /// 频道名称.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用于显示频道信息的URL地址.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 频道描述.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// css样式配置相对路径.(如"/Content/style.css")
        /// </summary>
        public string StyleConfigurePath { get; set; }

        /// <summary>
        /// Banner图片地址.
        /// </summary>
        public string BannerUrl { get; set; }

        /// <summary>
        /// 频道所有分组信息.
        /// </summary>
        public virtual List<Group> Groups { get; set; }
    }
}