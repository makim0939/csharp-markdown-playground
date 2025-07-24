using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace MarkdownPlayground.Model
{
    internal static class MarkdownFileService
    {

        //mdファイルのセクションを解析し、DailyReportModel型に変換
        public static DailyReportModel ReadMdFile(DailyReportModel Report)
        {
            // mdファイル読み込み
            string[] lines = File.ReadAllLines(@".\日報2025-07-24.md");


            List<Section> sections = [];
            string heading  = string.Empty;
            foreach (string line in lines)
            {
                if(line.StartsWith("##"))
                {
                   heading = line.Replace("#", "").Replace(" ", "");
                    continue;
                }

                Report.Sections.ForEach(
                    section => 
                    { 
                        if(section.Title == heading)
                        {
                            section.Content += $"{line}\n";
                        }
                    });
            }

            // 入力種別毎に調整
            Report.Sections.ForEach(
                section =>
                {
                    switch (section.Type)
                    {
                        case "Text":
                            section.Content = section.Content.Replace("\n", " ");
                            break;
                        case "Choice":
                            section.Content = section.Content.Replace("\n", "");
                            break;
                        default:
                            break;
                    }
                });

            return Report;
        }
    }
}
