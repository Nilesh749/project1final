using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class choicefactory
    {
        private Dictionary<Choice, Func<Menus>> choiceMapper;

        public choicefactory()
        {
            choiceMapper = new Dictionary<Choice, Func<Menus>>();
            choiceMapper.Add(Choice.Experiencemenu, () => { return new Experiencemenu(); });
            choiceMapper.Add(Choice.Eductaionmenu, () => { return new Educationmenu(); });
            choiceMapper.Add(Choice.Skillsmenu, () => { return new SkillsMenu(); });
            choiceMapper.Add(Choice.TechnologicalSkillsmenu, () => { return new TechnologicalSkills(); });
            choiceMapper.Add(Choice.Contactmenu, () => { return new Contactmenu(); });
        }

        public Menus Getmenuperchoice(Choice choice)
        {
            return choiceMapper[choice]();
        }
    }
}
