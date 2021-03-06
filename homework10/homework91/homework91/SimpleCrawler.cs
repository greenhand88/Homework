﻿using homework91;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        /*（1）只爬取某个指定网站上的网页 
          （2）只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL。
          （3）相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址进行爬取。
          （4） 尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。
           将上次作业的爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。
        */
        private List<KeyValuePair<string, bool>>  urls = new List<KeyValuePair<string, bool>>();
        private int count = 0;
        private string url = "";
        public SimpleCrawler()
        {
        }
        public void ADD(string starturl, string parturl)
        {
            url = starturl + parturl;//（3）相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址进行爬取。
            try {
                urls.Add(new KeyValuePair<string, bool>(url,false)); }
            catch (Exception e) { Console.WriteLine(e); }
        }

        public void Crawl(int count)
        {
            Form2 a = new Form2();
            //Console.WriteLine("开始爬行了.... ");
            a.textBox1_TextChanged("开始爬行了.... \n");
            while (true)
            {
                string current = null;
                //foreach (string url in urls.Keys)
                Parallel.ForEach(urls, url =>
                {
                    if (!url.Value)
                    current = url.Key;
                    bool flag = false;
                    try
                    {
                        flag = Regex.IsMatch(current, @".*html") || Regex.IsMatch(current, @".*aspx") || Regex.IsMatch(current, @".*jsp");//（2）只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL。
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);//此处可以用另一个窗体显示
                    }
                    if (current == null || count > 10 || flag == false) { a.textBox1_TextChanged("无法解析\n");}
                    //Console.WriteLine("爬行" + current + "页面!");
                    else
                    {
                        a.textBox1_TextChanged("爬行" + current + "页面!\n");
                        string html = DownLoad(current); // 下载
                        url = new KeyValuePair<string, bool>(url.Key, true);//此处已经true了
                        count++;
                        Parse(html);//解析,并加入新的链接
                                    //Console.WriteLine("爬行结束");
                        a.textBox1_TextChanged("爬行结束");
                        a.ShowDialog();
                    }  
                });
                
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;

                //if (urls[strRef] == null) urls[strRef] = false;
                KeyValuePair<string, bool> temp = new KeyValuePair<string, bool>(strRef, true);
                //if (urls[urls.BinarySearch(temp)]==null)
            }
        }
    }
}
