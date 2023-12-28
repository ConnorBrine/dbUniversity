using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.AcademicAffair.View;
using The_amazing_of_numbers.Area.StudentArea.View;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.Area.Global;
using static The_amazing_of_numbers.Area.AcademicAffair.Controllers.AcademicAffairController;
using ZXing;
using System.Web.UI.WebControls;

namespace The_amazing_of_numbers.Area.AcademicAffair.Controllers

{
    internal class AcademicAffairController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;

        string year; string department; string semester;
        public class datatransfer
        {
            public int op1;
            public int op2;
        }
        public class weekdata
        {
            public int daylimit; //if week only have 1: option1; if week have 2: option2
            public int timelimit; //max time for the subject
            public List<datatransfer> daysdata = new List<datatransfer>(); //will give days in week
            public List<int> timedata = new List<int>(); //by the1 daysdata, using for calculate the time (ca học)
            public bool days_equal_time; //within this, each daysdata will be timedata
            public int isDP = -1;
        }

        weekdata data;
        
        public void AcademicAffairHomeView(User user_model)
        {
            cur_user = user_model;
            new AcademicAffairMainForm(cur_user).Show();
        }
        public List<Subject_> SearchingCourse(string strSearch)
        {
            try
            {
                List<Subject_> list;                            
                list = db.Subject_s.Where(model => 
                model.course_id.ToLower().Contains(strSearch.ToLower())
                ||
                model.course_name.ToLower().Contains(strSearch.ToLower())).ToList();                
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public List<Subject_> SearchingCourseDepart(string strSearch)
        {
            try
            {
                List<Subject_> list;
                if (strSearch != "All")
                {
                    list = db.Subject_s.Where(model =>
                    model.department_id.ToLower().Contains(strSearch.ToLower())).ToList();
                }
                else
                {
                    list = db.Subject_s.ToList();
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public List<string> SearchByClassFilter(string year, string department, string semester)
        {
            Console.WriteLine(year + " " + department + " " + semester);

            try
            {
                this.year = year;
                this.department = department;
                this.semester = semester;
                List<string> list = new List<string>();

                if (year == "Year 1")
                {
                    if (semester == "1A")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv1_HK1A_IT; break;
                            case "DP": list = GlobalClass.sv1_HK1A_DP; break;
                            case "TA": list = GlobalClass.sv1_HK1A_TA; break;
                            case "Practice": list = GlobalClass.sv1_HK1A_Practice; break;
                        }
                    }
                    else if (semester == "1B")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv1_HK1B_IT; break;
                            case "Math": list = GlobalClass.sv1_HK1B_Math; break;
                            case "Bonus": list = GlobalClass.sv1_HK1B_Extra; break;
                            case "TA": list = GlobalClass.sv1_HK1B_TA; break;
                            
                        }
                    }
                    else if (semester == "2A")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv1_HK2A_IT; break;
                            case "Math": list = GlobalClass.sv1_HK2A_Math; break;
                            case "Practice": list = GlobalClass.sv1_HK2A_TA; break;
                            case "TA": list = GlobalClass.sv1_HK2A_TA; break;
                            case "PE": list = GlobalClass.sv1_HK2A_PE; break;
                        }
                    }
                    else
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv1_HK2B_IT; break;                           
                            case "Practice": list = GlobalClass.sv1_HK2B_Practice; break;
                            case "Bonus": list = GlobalClass.sv1_HK2B_Extra; break;
                            case "TA": list = GlobalClass.sv1_HK2B_TA; break;
                        }
                    }
                }
                else if (year == "Year 2")
                {
                    if (semester == "1A")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv2_HK1A_IT; break;
                            case "Practice": list = GlobalClass.sv2_HK1A_Practice; break;
                            case "TA": list = GlobalClass.sv2_HK1A_TA; break;
                        }
                    }
                    else if (semester == "1B")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv2_HK1B_IT; break;
                            case "Practice": list = GlobalClass.sv2_HK1B_Practice; break;
                            case "TA": list = GlobalClass.sv2_HK1B_TA; break;
                        }
                    }
                    else if (semester == "2A")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv2_HK2A_IT; break;
                            case "Practice": list = GlobalClass.sv2_HK2A_Practice; break;
                            case "TA": list = GlobalClass.sv2_HK2A_TA; break;
                            case "PE": list = GlobalClass.sv2_HK2A_PE; break;
                        }
                    }
                    else
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv2_HK2B_IT; break;
                            case "Bonus": list = GlobalClass.sv2_HK2B_Extra; break;
                            case "TA": list = GlobalClass.sv2_HK2B_TA; break;
                        }
                    }
                }
                else if (year == "Year 3")
                {
                    if (semester == "1A")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv3_HK1A_IT; break;
                            case "Math": list = GlobalClass.sv3_HK1A_Math; break;
                            case "TA": list = GlobalClass.sv3_HK1A_TA; break;
                        }
                    }
                    else if (semester == "1B")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv3_HK1B_IT; break;
                            case "Practice": list = GlobalClass.sv3_HK1B_Practice; break;
                            case "TA": list = GlobalClass.sv3_HK1B_TA; break;
                        }
                    }
                    else if (semester == "2A")
                    {
                        switch (department)
                        {
                            case "IT": list = GlobalClass.sv3_HK2A_IT; break;
                            case "Practice": list = GlobalClass.sv3_HK2A_Practice; break;
                            case "TA": list = GlobalClass.sv3_HK2A_TA; break;
                            case "PE": list = GlobalClass.sv3_HK2A_PE; break;
                        }
                    }
                    else
                    {
                        list = GlobalClass.sv3_HK2B_IT;
                    }
                }
                else list = GlobalClass.sv4;

                

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }
        public List<Subject_> StringtoSubject(List<string> subjectname)
        {
            List<Subject_> result = new List<Subject_>();
            subjectname.ForEach(s =>
            {
                Subject_ subject = db.Subject_s.Where(model => model.course_name == s).FirstOrDefault();
                result.Add(subject);
            });
            return result;
        } 
        public string printInformation(string coursename, string departID, string semesterBox, string year)
        {
            int available_classes = 0;
            string tmp = "Course Name: " + coursename + "\nDepartment Option: " + departID + "\nSemester: HK" + semesterBox + "\nAvailable classes: ";
            available_classes = checkAvailableClasses(year);

            tmp += available_classes;
            return tmp;
        }
        public int checkAvailableClasses(string year)
        {
            int available_classes = 0;
            if (year == "Year 1") available_classes = 4;
            else if (year == "Year 2") available_classes = 7;
            else if (year == "Year 3") available_classes = 10;
            else available_classes = 9;
            return available_classes;
        }
        public string getTime(int currentTime, int limitTime)
        {
            int tmp = 0;
            if (currentTime == 1)
            {
                tmp = 387;
            }
            else if (currentTime == 2)
            {
                tmp = 540;
            }
            else if (currentTime == 3)
            {
                tmp = 738;
            }
            else
            {
                tmp = 903;
            }
            //each lesson = 45 minutes
            tmp = ((45 * limitTime) + tmp) / 60;
               
             


                return Convert.ToString(tmp);
        }  
        public weekdata SubjectProp(string namesubject, string departID)
        {
            weekdata subject = new weekdata();

            try
            {
                datatransfer a = new datatransfer();
                if (departID == "IT")
                {
                    subject.timelimit = 3;
                    if (GlobalClass.Math.Contains(namesubject))
                    {
                        //
                        subject.timelimit = 3;
                        subject.daylimit = 2;
                        if(namesubject == "Discrete mathematics" || namesubject == "Linear algebra")
                        {
                            Console.WriteLine("Here");
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            
                            subject.timedata.Add(1);
                            subject.timedata.Add(2);
                            subject.days_equal_time = false;
                        }
                        else //"Probability and statistics"
                        {
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(2);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(1);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(1);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(1);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(2);
                           
                            subject.days_equal_time = true;
                        }
                           
                        subject.days_equal_time = true;
                    }
                    else if (GlobalClass.Practice.Contains(namesubject))
                    {
                        subject.timelimit = 5;
                        subject.daylimit = 1; //days
                        if (namesubject.Contains("Practice programing C") || 
                            namesubject.Contains("Practice computer architecture") ||
                            namesubject.Contains("Practice operating system")
                            )
                        {
                            a.op1 = 3; a.op2 = 0;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(1);
                            subject.timedata.Add(3);

                            subject.days_equal_time = false;
                        }
                        else
                        {
                            
                            a.op1 = 7; a.op2 = 0;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(1);

                            a = new datatransfer();
                            a.op1 = 7; a.op2 = 0;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 5; a.op2 = 0;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(1);

                           

                            a = new datatransfer();
                            a.op1 = 5; a.op2 = 0;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            subject.days_equal_time = true;
                        }

                    }
                    else //IT
                    {
                        subject.timelimit = 3;
                        subject.daylimit = 2;

                        if(namesubject.Contains("Programing C")
                            || 
                           namesubject.Contains("Software technology"))
                        {                            
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 3;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            
                            Console.WriteLine("C and Software");
                        }
                        else if(namesubject.Contains("Computer architecture and Operating system"))
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;   
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);
                        }
                        else if(namesubject.Contains("Pratice graph theory"))
                        {
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);
                        }
                        else if(namesubject.Contains("Data structures and algorithms"))
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);
                        }
                        else if (namesubject.Contains("Pratice graph theory"))
                        {
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);
                        }
                        else if (namesubject.Contains("Programming technique"))
                        {
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);
                        }
                        else if (namesubject.Contains("Practice database fundamentals"))
                        {
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);
                        }
                        else if (namesubject.Contains("Object-oriented programming"))
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 3;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);
                        }
                        else if (namesubject.Contains("Practical application programming with Java"))
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 7;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);
                        }
                        else if (namesubject.Contains("Web programming"))
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);
                        }
                        else if (namesubject.Contains("Programming on the Windows platform") )
                        {
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);
                        }//only this condition will need add more room
                        else if (namesubject.Contains("Computer network") )
                        {
                            a.op1 = 3; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 3;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 3;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);
                        } //when seperate room, this state have some trouble
                        else if (namesubject.Contains("Information security") )
                        {
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 4;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(2);

                        } //1 class with morning
                        else if (namesubject.Contains("Information technology project management") )
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(2);

                        } //1 class with morning
                        else if(namesubject.Contains("Artificial intelligence"))
                        {
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 4; a.op2 = 6;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(3);

                            a = new datatransfer();
                            a.op1 = 3; a.op2 = 7;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);

                            a = new datatransfer();
                            a.op1 = 2; a.op2 = 5;
                            subject.daysdata.Add(a);
                            subject.timedata.Add(4);
                        }
                        subject.days_equal_time = true;

                    }
                }
                else if(departID == "VJIT")
                {
                    subject.timelimit = 3;
                    subject.daylimit = 2;
                    if(namesubject.Contains("Project design 1"))
                    {

                        a.op1 = 2; a.op2 = 4;
                        subject.daysdata.Add(a);

                        subject.timedata.Add(1);
                        subject.timedata.Add(2);

                        subject.days_equal_time = false;

                    }
                    else
                    {
                        a.op1 = 3; a.op2 = 5;
                        subject.daysdata.Add(a);

                        a = new datatransfer();
                        a.op1 = 2; a.op2 = 4;
                        subject.daysdata.Add(a);


                        subject.timedata.Add(1);
                        subject.timedata.Add(2);

                        subject.days_equal_time = false;
                    }
                }
                else if (departID == "TA")
                {
                    subject.daylimit = 2;
                    subject.timelimit = 3;
                    
                    a.op1 = 2; a.op2 = 4;
                    subject.daysdata.Add(a);

                    a = new datatransfer();
                    a.op1 = 4; a.op2 = 6;
                    subject.daysdata.Add(a);

                    a = new datatransfer();
                    a.op1 = 2; a.op2 = 6;
                    subject.daysdata.Add(a);

                    subject.timedata.Add(3);
                    subject.timedata.Add(4);

                    subject.days_equal_time = false;
                }
                else if (departID == "SC")
                {
                    subject.daylimit = 1;
                    subject.timelimit = 3;
                    
                    a.op1 = 2; a.op2 = 0;
                    subject.daysdata.Add(a);

                    subject.timedata.Add(1);
                    subject.timedata.Add(2);
                    subject.days_equal_time = false;

                }
                else if (departID == "PE")
                {
                    subject.daylimit = 2;
                    subject.timelimit = 5;
                                       
                    a.op1 = 2; a.op2 = 5;
                    subject.daysdata.Add(a);

                    a = new datatransfer();
                    a.op1 = 3; a.op2 = 6;
                    subject.daysdata.Add(a);

                    a = new datatransfer();
                    a.op1 = 4; a.op2 = 7;
                    subject.daysdata.Add(a);

                    subject.timedata.Add(3);
                    subject.days_equal_time = false;
                }
                else //DP
                {
                    if (namesubject.Contains("1"))
                    {
                        
                        subject.daylimit = 2;
                        subject.timelimit = 3;
                        a.op1 = 2; a.op2 = 3;
                        subject.daysdata.Add(a);

                        a = new datatransfer();
                        a.op1 = 4; a.op2 = 5;
                        subject.daysdata.Add(a);
                        
                        subject.timedata.Add(1);
                        subject.days_equal_time = false;
                        Console.WriteLine("1 here");
                    }
                    else if(namesubject.Contains("2"))
                    {
                        subject.isDP = 2;
                        subject.daylimit = 2;
                        subject.timelimit = 1;
                        a.op1 = 2; a.op2 = 3;
                        subject.daysdata.Add(a);

                        a = new datatransfer();
                        a.op1 = 4; a.op2 = 5;
                        subject.daysdata.Add(a);
                        
                        subject.timedata.Add(2);
                        subject.days_equal_time = false;
                        Console.WriteLine("2 here");
                    }
                    else if(namesubject.Contains("3"))
                    {
                        subject.isDP = 3;
                        subject.daylimit = 2;
                        subject.timelimit = 1;
                        a.op1 = 2; a.op2 = 3;
                        subject.daysdata.Add(a);

                        a = new datatransfer();
                        a.op1 = 4; a.op2 = 5;
                        subject.daysdata.Add(a);

                        subject.timedata.Add(1);
                        subject.days_equal_time = false;
                        Console.WriteLine("3 here");
                    }
                    else //4
                    {
                        subject.daylimit = 2;
                        subject.timelimit = 5;
                        a.op1 = 2; a.op2 = 3;
                        subject.daysdata.Add(a);

                        a = new datatransfer();
                        a.op1 = 4; a.op2 = 5;
                        subject.daysdata.Add(a);

                        subject.timedata.Add(3);
                        subject.days_equal_time = false;
                        Console.WriteLine("4 here");
                    }

                    //Console.WriteLine("Wrong");

                }
                //IT, PE
                Console.WriteLine("Count: " + subject.daysdata.Count + " and " + subject.timedata.Count);
                return subject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return subject;
            }
        }
        public void displayDays()
        {
            Panel p = new Panel();

        }
        public List<string> LoadSubject()
        {
            List<string> lst = (from de in db.Departments
                               select de.department_id).ToList();
            return lst;
        }
    }
}
