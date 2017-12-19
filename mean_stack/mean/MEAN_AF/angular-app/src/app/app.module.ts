import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { TaskNewComponent } from './task-new/task-new.component';
import { TaskListComponent } from './task-list/task-list.component';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { TaskService } from './task.service';


@NgModule({
  declarations: [
    AppComponent,
    TaskNewComponent,
    TaskListComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [TaskService],
  bootstrap: [AppComponent]
})
export class AppModule { }