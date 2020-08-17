import { Component, OnInit, Inject } from '@angular/core';
import { Group } from '../group';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-group',
  templateUrl: './add-group.component.html',
  styleUrls: ['./add-group.component.css']
})

export class AddGroupComponent implements OnInit {
  myGroup: Group;
  private _httpClient: HttpClient;
  private _base: string;
  groupForm: FormGroup;


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  this.myGroup = {
    groupID: 0,
    name: '',
    description: '',
    mentorId: 0,
    };
    this._httpClient = http;
    this._base = baseUrl;
  }

  postGroup() {
    this.myGroup = this.groupForm.value;
    this._httpClient.post<Group>(this._base + 'api/groups', this.myGroup).subscribe((result) => {
      alert("Success :)")
    },
      (error) => {
        console.error(error);
      });
  }

  private initializeForm() {
    this.groupForm = new FormGroup({
      'name': new FormControl(null),
      'description': new FormControl(null),
     });
  }   

  ngOnInit() {
    this.initializeForm();
  }

}
