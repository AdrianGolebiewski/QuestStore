import { Component, Inject } from '@angular/core';
import { UsersFull } from '../../user/usersFull';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-my-students',
  templateUrl: './get-my-students.component.html',
  styleUrls: ['./get-my-students.component.css']
})
export class GetMyStudentsComponent {
  users: UsersFull[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UsersFull[]>(baseUrl + 'api/mentor').subscribe(result => {
      this.users = result;
    }, error => console.error(error));

  }

}
