using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UNSD.TDT.FileService.Model
{
    public class FileUpload
    {
        public string FileName { get; set; }
        public int UserId { get; set; }
        public byte[] FileStream { get; set; }
    }
}
