using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class EducationChoicefactory
    {
        private Dictionary<EducationChoice, Func<Educationmenus>> EducationchoiceMapper;

        public EducationChoicefactory()
        {
            EducationchoiceMapper = new Dictionary<EducationChoice, Func<Educationmenus>>();
            EducationchoiceMapper.Add(EducationChoice.csyr1, () => { return new CSyear1(); });
            EducationchoiceMapper.Add(EducationChoice.csyr2, () => { return new CSyear2(); });
            EducationchoiceMapper.Add(EducationChoice.Additional_trainings, () => { return new Additional_trainings(); });
            EducationchoiceMapper.Add(EducationChoice.goback, () => { return new Mainmenu(); });
        }

        public Educationmenus Getmenuperchoice(EducationChoice choice)
        {
            return EducationchoiceMapper[choice]();
        }
    }
}
