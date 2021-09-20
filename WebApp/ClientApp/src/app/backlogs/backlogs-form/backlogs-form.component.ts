import { Component, OnInit } from '@angular/core';
import { BacklogsService } from '../../shared/backlogs.service';

@Component({
  selector: 'app-backlogs-form',
  templateUrl: './backlogs-form.component.html',
  styles: [
  ]
})
export class BacklogsFormComponent implements OnInit {

  constructor(public service: BacklogsService) { }

  ngOnInit(): void {
  }

}
