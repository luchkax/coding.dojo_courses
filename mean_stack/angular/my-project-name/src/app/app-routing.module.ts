import { LandingComponent } from './landing/landing.component';
import { HomeComponent } from './home/home.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: LandingComponent,
    children: [] 
  },
  {
    path: 'home/test',
    pathMatch: 'full',
    component: HomeComponent,
    children: [] 
  },
  {
    path: '**',
    component: PagenotfoundComponent,
    children: [] 
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
