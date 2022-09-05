using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoApp.Models
{
    /// <summary>
    /// 视频集
    /// </summary>
    public class VideoSerie
    {
        public int Id { get; set; }
        /// <summary>
        /// 序号：剧集数：第几集
        /// </summary>
        public int SerialNumber { get; set; }
        public Video Video { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}
