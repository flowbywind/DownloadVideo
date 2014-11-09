using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadVideo.Model {
    public class DownloadViewModel {
        /// <summary>
        /// key
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 视频名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 视频来源
        /// </summary>
        public string UrlSource { get; set; }
        /// <summary>
        /// 下载地址
        /// </summary>
        public IList<string> UrlDownloadList { get; set; }
        /// <summary>
        /// 视频类目(频道)
        /// </summary>
        public CategoryType Category { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public DownloadStatus Status { get; set; }
        /// <summary>
        /// 视频来源
        /// </summary>
        public VideoSourceType VideoSourceType { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
    /// <summary>
    /// 视频类目地址集合 
    /// </summary>
    public class UrlCategoryViewModel {
        /// <summary>
        /// 视频类目
        /// </summary>
        public CategoryType Category { get; set; }
        /// <summary>
        /// 类目url
        /// </summary>
        public string UrlCategory { get; set; } 
    }
    public enum DownloadStatus {
        /// <summary>
        /// 已创建视频来源
        /// </summary>
        HasCreated = 3,
        /// <summary>
        /// 已获取下载地址
        /// </summary>
        HasGetDownloadUrl = 5,
        /// <summary>
        /// 下载中
        /// </summary>
        Downloading = 7
    }
    /// <summary>
    /// 视频类目(频道)
    /// </summary>
    public enum CategoryType {
        /// <summary>
        /// 搞笑
        /// </summary>
        fun = 3,
        /// <summary>
        /// 原创
        /// </summary>
        dv = 5
    }

    public enum VideoSourceType {
        Youku = 1
    }
}
