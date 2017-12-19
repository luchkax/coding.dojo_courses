import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { BehaviorSubject } from 'Rxjs';
import { Task } from './task';

@Injectable()
export class TaskService {
  tasksObserver = new BehaviorSubject([]);

  constructor(private _http: Http) { }

  retrieveAll() {
    this._http.get('http://localhost:8000/api/tasks').subscribe(
      tasks => this.tasksObserver.next(tasks.json()),
      errorResponse => console.log("Retrieve all error", errorResponse)
    );
  }

  createTask(task: Task) {
    this._http.post('http://localhost:8000/api/tasks', task).subscribe(
      response => this.retrieveAll(),
      errorResponse => console.log("Create task error", errorResponse)
    );
  }

}