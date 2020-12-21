interface Iperson{
    firstName:string;
    lastName:string;
    GetFullName();
}
class person implements Iperson{
    firstName: string;    lastName: string;
    GetFullName() {
       console.log(this.firstName+" "+this.lastName);
    }


}
let objP:person=new person();
objP.firstName="priyanka";
objP.lastName="Nimmagadda";
objP.GetFullName();