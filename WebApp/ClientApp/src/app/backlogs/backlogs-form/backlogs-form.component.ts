import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { from } from 'rxjs';
import { Backlogs } from '../../shared/backlogs.model';
import { BacklogsService } from '../../shared/backlogs.service';
import { Priorities } from '../../utilities/priorities';

@Component({
  selector: 'app-backlogs-form',
  templateUrl: './backlogs-form.component.html',
  styles: [
  ]
})
export class BacklogsFormComponent implements OnInit {
  priority: any;
  priorities = Priorities;
  priorityKeys: any[] = [];

  constructor(public service: BacklogsService, private toastr: ToastrService)
  {
    this.priorityKeys = Object.keys(this.priorities).filter(p => !isNaN(Number(p)));
    //console.log(Object.keys(this.priorities).filter(p => parseInt(p)));
    console.log("priority Keys =", this.priorityKeys);
  }

  ngOnInit(): void {
    this.service.formData.priority = this.priorities.Low;
    console.log(this.priorities[1]);
  }

  primaryChangeHandler(value: any) {
    console.log(value);
    //this.priority = this.priorities[value];    
  }

  onSubmit(form: NgForm) {
    this.service.postBacklogs().subscribe(
      res => {
        this.resetBacklogForm(form);
        this.service.loadBacklogList();
        this.toastr.success('Added successfully', 'Backlog');
      },
      err => {
        console.log(err);
      }
    );
  }

  resetBacklogForm(form: NgForm) {
    form.resetForm();
    this.service.formData = new Backlogs();
  }
}
