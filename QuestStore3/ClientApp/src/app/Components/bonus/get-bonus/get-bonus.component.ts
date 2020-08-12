import { Component, Inject } from '@angular/core';
import { Bonus } from '../bonus';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-bonus',
  templateUrl: './get-bonus.component.html',
  styleUrls: ['./get-bonus.component.css']
})
export class GetBonusComponent {
  public bonuses: Bonus[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Bonus[]>(baseUrl + 'bonuses').subscribe(result => {
      this.bonuses = result;
    }, error => console.error(error));
  }


}
