using KO.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entities.Entities
{
    public class Exam : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string QuestionOne { get; set; }      
        public string QuestionTwo { get; set; }        
        public string QuestionThree { get; set; }       
        public string QuestionFour { get; set; }     
        public string QOneAOne { get; set; }
        public string QOneATwo { get; set; }
        public string QOneAThree { get; set; }
        public string QOneAFour { get; set; }
        public string QOneTrue { get; set; }
        public string QTwoAOne { get; set; }
        public string QTwoATwo { get; set; }
        public string QTwoAThree { get; set; }
        public string QTwoAFour { get; set; }
        public string QTwoTrue { get; set; }
        public string QThreeAOne { get; set; }
        public string QThreeATwo { get; set; }
        public string QThreeAThree { get; set; }
        public string QThreeAFour { get; set; }
        public string QThreeTrue { get; set; }
        public string QFourAOne { get; set; }
        public string QFourATwo { get; set; }
        public string QFourAThree { get; set; }
        public string QFourAFour { get; set; }
        public string QFourTrue { get; set; }
        public string CreatedDate { get; set; }
    }
}
