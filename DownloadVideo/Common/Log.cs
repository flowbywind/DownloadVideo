using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadVideo.Common {
     public  class Log {

        private const string _baseDirectory = @"d:\tmp\";
        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteErrorLog(string msg) {
            string path = _baseDirectory+"errorLog.txt";
            using (StreamWriter sw = File.CreateText(path)) {
                sw.WriteLine(msg);
            }
        }
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="listStr"></param>
        /// <param name="logName"></param>
        public static void WriteLog(List<string> listStr, string logName) {
            string path = _baseDirectory + logName;
            if (!File.Exists(path)) {
                using (FileStream fs = File.Create(path)) {
                   
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                foreach (string str in listStr) {
                    sw.WriteLine(str);
                }
            }
        }
        /// <summary>
        /// 写入日志文件
        /// </summary>
        /// <param name="content">文件内容</param>
        /// <param name="logName">文件名</param>
        public static void WriteLog(string content, string logName) {
            string path = _baseDirectory + logName;
            using (StreamWriter sw = File.CreateText(path)) {
                sw.WriteLine(content);
            }
        }
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="logName">文件名</param>
        /// <returns></returns>
        public static string ReadLog(string logName) {
            string path = _baseDirectory + logName;
            if (!File.Exists(path)) {
                throw new Exception("未找到文件");
            }
            using (StreamReader sr = File.OpenText(path)) {
                return sr.ReadLine();
            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="logName">文件名</param>
        public static void DeleteFile(string logName) {
            string filePath = _baseDirectory+logName;
            if (File.Exists(filePath)) {
                File.Delete(filePath);
            }
        }
    }
}
