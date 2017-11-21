using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JCSoft.Utils.Commons.Images
{
    public class ImageUtils
    {
        private static SortedDictionary<int, ImageType> _imageTypeDict;

        private static void LoadImageTyps()
        {
            if(_imageTypeDict == null)
            {
                _imageTypeDict = new SortedDictionary<int, ImageType>();
                _imageTypeDict.Add((Int32)ImageType.None, ImageType.None);
                _imageTypeDict.Add((Int32)ImageType.BMP, ImageType.BMP);
                _imageTypeDict.Add((Int32)ImageType.GIF, ImageType.GIF);
                _imageTypeDict.Add((Int32)ImageType.JPG, ImageType.JPG);
                _imageTypeDict.Add((Int32)ImageType.PCX, ImageType.PCX);
                _imageTypeDict.Add((Int32)ImageType.PNG, ImageType.PNG);
                _imageTypeDict.Add((Int32)ImageType.PSD, ImageType.PSD);
                _imageTypeDict.Add((Int32)ImageType.RAS, ImageType.RAS);
                _imageTypeDict.Add((Int32)ImageType.SGI, ImageType.SGI);
                _imageTypeDict.Add((Int32)ImageType.TIFF, ImageType.TIFF);
            }
        }

        /// <summary>
        /// 根据文件头判断是否是图片文件，并返回其类型
        /// </summary>
        /// <param name="buf">文件流</param>
        /// <returns></returns>
        public static ImageType CheckImageType(byte[] buf)
        {
            if (buf == null || buf.Length < 2)
            {
                return ImageType.None;
            }

            LoadImageTyps();
            int key = (buf[1] << 8) + buf[0];
            ImageType s;
            if (_imageTypeDict.TryGetValue(key, out s))
            {
                return s;
            }
            return ImageType.None;
        }

        /// <summary>
        /// 根据文件头部判断是否是图片
        /// </summary>
        /// <param name="buf">文件流</param>
        /// <returns></returns>
        public static Boolean IsImage(byte[] buf)
        {
            return CheckImageType(buf) != ImageType.None;
        }

        /// <summary>
        /// 读取文件,判断是否是图片并返回图片类型
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static ImageType CheckImageType(string path)
        {
            byte[] buf = new byte[2];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int i = sr.BaseStream.Read(buf, 0, buf.Length);
                    if (i != buf.Length)
                    {
                        return ImageType.None;
                    }
                }
            }
            catch (Exception ex)
            {
                //Debug.Print(exc.ToString());
                return ImageType.None;
            }
            return CheckImageType(buf);
        }
    }
}
