class Department{
    id:number;
    name:string;
    location:string;
    
    constructor(empId:number,empName:string,empLocation:string){
        this.id=empId;
        this.name=empName;
        this.location=empLocation;
    } 
    Display=()=>{
        console.log("Emp_Id:"+this.id+","+"Emp_Name:"+this.name+","+"Emp_location:"+this.location);
    }

}
let obj1:Department=new Department(250,'Priyanka',"TamilNadu")
obj1.Display();