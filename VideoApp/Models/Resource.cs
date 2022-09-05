using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoApp.Models
{
    /// <summary>
    /// 资源：视频，音频，图片。。。
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 资源URL
        /// </summary>
        public string Url { get; set; }

        public ResourceType? Type { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        public enum ResourceType
        {
            Video,
            Audio,
            Image,
            Text
        }
    }
}
