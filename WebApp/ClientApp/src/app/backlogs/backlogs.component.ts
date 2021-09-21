import { Component, OnInit } from '@angular/core';
import { BacklogsService } from '../shared/backlogs.service';

@Component({
  selector: 'app-backlogs',
  templateUrl: './backlogs.component.html',
  styles: [
  ]
})
export class BacklogsComponent implements OnInit {

  constructor(public service: BacklogsService) { }

  ngOnInit(): void {
    this.service.loadBacklogList();
  }

}
