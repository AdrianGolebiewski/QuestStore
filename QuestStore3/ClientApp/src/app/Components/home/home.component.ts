import { Component, Inject } from '@angular/core';
import { User } from '../user/user';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpService } from '../../services/http.service';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgModule } from '@angular/core';
import { Quest } from '../quest/quest';
import { Bonus } from '../bonus/bonus';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',

})
export class HomeComponent {
  public isCollapsed = true;
  public isCollapsedB = true;
  public isCollapsedC = true;
  public isCollapsedD = true;
  public quests: Quest[];
  public bonuses: Bonus[];



  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Quest[]>(baseUrl + 'api/quest').subscribe(result => {
      this.quests = result;
    }, error => console.error(error));

    http.get<Bonus[]>(baseUrl + 'api/bonuses').subscribe(result => {
      this.bonuses = result;
    }, error => console.error(error));
  }



}


