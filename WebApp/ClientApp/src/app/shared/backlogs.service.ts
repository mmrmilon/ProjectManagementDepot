import { Injectable } from '@angular/core';
import { Backlogs } from './backlogs.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BacklogsService {

  constructor(private http: HttpClient) {
  }

  readonly baseUrl = 'https://localhost:44356/api/backlog';
  formData: Backlogs = new Backlogs();
  list: Backlogs[];

  postBacklogs() {
    return this.http.post(this.baseUrl, this.formData);
  }

  loadBacklogList() {
    this.http.get(this.baseUrl)
      .toPromise()
      .then(res => this.list = res as Backlogs[])
  }
}
