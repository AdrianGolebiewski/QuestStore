import { Component, Inject } from '@angular/core';
import { Group } from '../../group/group';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-my-groups',
  templateUrl: './get-my-groups.component.html',
  styleUrls: ['./get-my-groups.component.css']
})
export class GetMyGroupsComponent {
  myGroup: Group[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Group[]>(baseUrl + 'api/groups').subscribe(result => {
      this.myGroup = result;
    }, error => console.error(error));

  }
}
