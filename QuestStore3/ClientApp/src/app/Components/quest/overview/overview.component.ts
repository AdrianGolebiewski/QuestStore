import { Component, Inject } from '@angular/core';
import { Quest } from '../quest';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrls: ['./overview.component.css']
})
export class OverviewComponent {

  public quests: Quest[];


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Quest[]>(baseUrl + 'quest').subscribe(result => {
      this.quests = result;
    }, error => console.error(error));

  }
}
