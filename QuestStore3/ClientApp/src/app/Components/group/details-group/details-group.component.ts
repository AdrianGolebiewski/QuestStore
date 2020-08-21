import { Component, OnInit, Inject } from '@angular/core';
import { UsersFull } from '../../user/usersFull';
import { GroupUser } from '../../user/groupUser';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { Group } from '../group';

@Component({
  selector: 'app-details-group',
  templateUrl: './details-group.component.html',
  styleUrls: ['./details-group.component.css']
})
export class DetailsGroupComponent implements OnInit {

  _http: HttpClient;
  _base: string;
  groupStudents: GroupUser[];
  idInt: number;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private id: ActivatedRoute) {
    this._http = http;
    this._base = baseUrl;
  }

  getGroupStudents(id: number) {
    let temp: Group;
    temp = {
      groupID:  id,
      description: 'a',
      mentorId: 0,
      name: 'a',
    }
    temp.groupID = id;
    this._http.post<GroupUser[]>(this._base + 'api/groups/details', temp).subscribe(result => {
    this.groupStudents = result;
  }, error => console.error(error));
}

  ngOnInit() {
    this.id.params.subscribe(params => {
      this.idInt = +params['id'];
      console.log(this.idInt);
      this.getGroupStudents(this.idInt);
    });
  }

}
