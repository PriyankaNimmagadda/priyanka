class Employee{
    id:number;
    name:string;
    salary:number;
    mobileNo:number;

    constructor(empId:number,empName:string,empSalary:number,empMobileNo:number)
    {
        this.id=empId;
      this.name=empName;
        this.salary=empSalary;
       this.mobileNo=empMobileNo;

    }
    Display=()=>{
        console.log("emp id:"+this.id+ " ","emp name:" +this.name +" "+"emp salary:"+this.salary+" "+"emp mobile no:"+7801036508);
    }
}
let obj:Employee=new Employee(250,"Priyanka",23000.50,7801036508)
obj.Display();
