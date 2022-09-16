using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class ExperienceChoicefactory
    {
        private Dictionary<ExperienceChoice, Func<Experiencemenulist>> ExperiencechoiceMapper;

        public ExperienceChoicefactory()
        {
            ExperiencechoiceMapper = new Dictionary<ExperienceChoice, Func<Experiencemenulist>>();
            ExperiencechoiceMapper.Add(ExperienceChoice.ceridian, () => { return new Experience_ceridian(); });
            ExperiencechoiceMapper.Add(ExperienceChoice.spoon, () => { return new Experience_spoon(); });
            ExperiencechoiceMapper.Add(ExperienceChoice.goback, () => { return new Mainmenu(); });
        }

        public Experiencemenulist Getmenuperchoice(ExperienceChoice choice)
        {
            return ExperiencechoiceMapper[choice]();
        }
    }
}
