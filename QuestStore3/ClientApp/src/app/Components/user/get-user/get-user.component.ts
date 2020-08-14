import { Component, Inject } from '@angular/core';
import { UsersFull } from '../usersFull';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-user',
  templateUrl: './get-user.component.html',
  styleUrls: ['./get-user.component.css']
})
export class GetUserComponent  {

  public users: UsersFull[];


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UsersFull[]>(baseUrl + 'api/users').subscribe(result => {
      this.users = result;
    }, error => console.error(error));

  }
}
