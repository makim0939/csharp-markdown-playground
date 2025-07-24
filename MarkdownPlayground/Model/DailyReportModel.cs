using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownPlayground.Model
{
    public class Section
    {
        public string Title { get; set; } = "";
        public string InternalName { get; set; } = "";
        public string Content { get; set; } = "";
        public string Type { get; set; } = "";
        public string[] choices { get; set; } = []; 

        public  Section(string title, string InternalName, string content, string type, string[] choices) 
        {
            this.Title = title;
            this.InternalName = InternalName;
            this.Content = content;
            this.Type = type;
            this.choices = choices;
        }
    }

    internal class DailyReportModel
    {
        public List<Section> Sections { get; set; } = [];

        public DailyReportModel()
        {
            this.Sections.Add(new Section("本日の目標", "goal", "", "Note", []));
            this.Sections.Add(new Section("成果", "result", "", "Note", []));
            this.Sections.Add(new Section("気分", "mood", "", "Choice", ["ノリノリ", "ボチボチ", "ダメダメ"]));
            this.Sections.Add(new Section("ヒトコト", "hitokoto", "", "Text", []));
        }
    }
}
