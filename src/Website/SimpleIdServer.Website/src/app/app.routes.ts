import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '', redirectTo: 'home', pathMatch: 'full'
  },
  {
    path: 'home',
    loadChildren: async () => (await import('./home/home.module')).HomeModule
  },
  {
    path: 'applications',
    loadChildren: async () => (await import('./applications/applications.module')).ApplicationsModule
  },
  {
    path: 'scopes',
    loadChildren: async () => (await import('./scopes/scopes.module')).ScopesModule
  },
  { path: '**', redirectTo: '/status/404' }
];