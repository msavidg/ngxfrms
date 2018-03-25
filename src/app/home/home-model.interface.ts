import { FilingRequestStatus } from '@app/home/filing-request-status.interface';

export interface HomeModel {
    status: number;
    filingRequestStatuses: Array<FilingRequestStatus>[];
}
