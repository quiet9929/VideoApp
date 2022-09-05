using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoApp.Models
{
    /// <summary>
    /// 视频
    /// </summary>
    public class Video
    {

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 封面图
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 视频类别
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// 视频类型
        /// </summary>
        public string VideoType { get; set; }

        /// <summary>
        /// 上映年份
        /// </summary>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// 来源国家
        /// </summary>
        public string OriginCountry { get; set; }
        /// <summary>
        /// 演员
        /// </summary>
        public ICollection<Actor> Actors { get; set; }

        /// <summary>
        /// 导演
        /// </summary>
        public Director Director { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public ICollection<Tag> Tags { get; set; }

        /// <summary>
        /// 剧集
        /// </summary>
        public ICollection<VideoSerie> VideoSeries { get; set; }

        /// <summary>
        /// 热度=观影数
        /// </summary>
        public int Heat { get; set; }
    }
}
