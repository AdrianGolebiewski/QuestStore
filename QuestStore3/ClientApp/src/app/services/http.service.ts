import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { User } from '../Components/user/user';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private httpService: HttpClient) { }

  public getData(route: string)
  {
    return this.httpService.get(route);
  }

  public getLogin(route: string, body: User)
  {
    return this.httpService.post(route, body);
  }

  public getIdentity(route: string)
  {
    return this.httpService.get<any>(route);
  }
  register(user: User) {
    return this.httpService.post('https://localhost:44390/api/account/reg', user);
  }
}


