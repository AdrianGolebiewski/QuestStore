import { DatePipe } from "@angular/common";

export enum Role {
  Admin, Mentor, Student
}

export interface UsersFull {

  id: number,
  firstName: string,
  lastName: string,
  email: string,
  phoneNumber: number
  password: string,
  confirmpassword: string,
  adress: string,
  postcode: number,
  registrationDate: string;
  role: number;
  status: number,
  checkboxanswer: boolean,
  quest: string;
  bonus: string;
}

