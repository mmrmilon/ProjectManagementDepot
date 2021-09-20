import { Injectable } from '@angular/core';
import { Backlogs } from './backlogs.model';

@Injectable({
  providedIn: 'root'
})
export class BacklogsService {

  constructor() { }

  readonly baseUrl = 'https://localhost:44356/api/Backlog';
  formData: Backlogs = new Backlogs();
}
