import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EditComponent } from './edit/edit.component';
import { HomeComponent } from './home/home.component';
import { ProductsComponent } from './products/products.component';
import { NewComponent } from './new/new.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent,
    children: [] 
  },
  {
  path: 'products',
  component: ProductsComponent,
  children: [] 
  },
  {
    path: 'products/new',
    component: NewComponent,
    children: [] 
  },
  {
    path: 'products/edit/:id',
    component: EditComponent,
    children: [] 
    },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})


export class AppRoutingModule { }
