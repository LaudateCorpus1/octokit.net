using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
#if NET_45
using System.Collections.Generic;
using System.Collections.ObjectModel;
#endif
#if NET_35
using System.Collections.Generic;
#endif

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Repository Branches API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/repos/branches">Repository Branches API documentation</a> for more details.
    /// </remarks>
    public interface IRepositoryBranchesClient
    {
        /// <summary>
        /// Gets all the branches for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-branches">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        Task<IReadOnlyList<Branch>> GetAll(string owner, string name);

        /// <summary>
        /// Gets all the branches for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-branches">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        Task<IReadOnlyList<Branch>> GetAll(long repositoryId);

        /// <summary>
        /// Gets all the branches for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-branches">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        Task<IReadOnlyList<Branch>> GetAll(string owner, string name, ApiOptions options);

        /// <summary>
        /// Gets all the branches for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-branches">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        Task<IReadOnlyList<Branch>> GetAll(long repositoryId, ApiOptions options);

        /// <summary>
        /// Gets the specified branch.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<Branch> Get(string owner, string name, string branch);

        /// <summary>
        /// Gets the specified branch.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<Branch> Get(long repositoryId, string branch);

        /// <summary>
        /// Edit the specified branch with the values given in <paramref name="update"/>
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="update">New values to update the branch with</param>
        [Obsolete("This existing implementation will cease to work when the Branch Protection API preview period ends.  Please use other RepositoryBranchesClient methods instead.")]
        Task<Branch> Edit(string owner, string name, string branch, BranchUpdate update);

        /// <summary>
        /// Edit the specified branch with the values given in <paramref name="update"/>
        /// </summary>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="update">New values to update the branch with</param>
        [Obsolete("This existing implementation will cease to work when the Branch Protection API preview period ends.  Please use other RepositoryBranchesClient methods instead.")]
        Task<Branch> Edit(long repositoryId, string branch, BranchUpdate update);

        /// <summary>
        /// Get the branch protection settings for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-branch-protection">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<BranchProtectionSettings> GetBranchProtection(string owner, string name, string branch);

        /// <summary>
        /// Get the branch protection settings for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-branch-protection">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<BranchProtectionSettings> GetBranchProtection(long repositoryId, string branch);

        /// <summary>
        /// Update the branch protection settings for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#update-branch-protection">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="update">Branch protection settings</param>
        Task<BranchProtectionSettings> UpdateBranchProtection(string owner, string name, string branch, BranchProtectionSettingsUpdate update);

        /// <summary>
        /// Update the branch protection settings for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#update-branch-protection">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="update">Branch protection settings</param>
        Task<BranchProtectionSettings> UpdateBranchProtection(long repositoryId, string branch, BranchProtectionSettingsUpdate update);

        /// <summary>
        /// Remove the branch protection settings for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-branch-protection">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<bool> DeleteBranchProtection(string owner, string name, string branch);

        /// <summary>
        /// Remove the branch protection settings for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-branch-protection">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<bool> DeleteBranchProtection(long repositoryId, string branch);

        /// <summary>
        /// Get the required status checks for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-required-status-checks-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<BranchProtectionRequiredStatusChecks> GetRequiredStatusChecks(string owner, string name, string branch);

        /// <summary>
        /// Get the required status checks for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-required-status-checks-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<BranchProtectionRequiredStatusChecks> GetRequiredStatusChecks(long repositoryId, string branch);

        /// <summary>
        /// Replace required status checks for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#update-required-status-checks-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="update">Required status checks</param>
        Task<BranchProtectionRequiredStatusChecks> UpdateRequiredStatusChecks(string owner, string name, string branch, BranchProtectionRequiredStatusChecksUpdate update);

        /// <summary>
        /// Replace required status checks for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#update-required-status-checks-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="update">Required status checks</param>
        Task<BranchProtectionRequiredStatusChecks> UpdateRequiredStatusChecks(long repositoryId, string branch, BranchProtectionRequiredStatusChecksUpdate update);

        /// <summary>
        /// Remove required status checks for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-required-status-checks-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<bool> DeleteRequiredStatusChecks(string owner, string name, string branch);

        /// <summary>
        /// Remove required status checks for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-required-status-checks-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<bool> DeleteRequiredStatusChecks(long repositoryId, string branch);

        /// <summary>
        /// Get the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<IReadOnlyList<string>> GetRequiredStatusChecksContexts(string owner, string name, string branch);

        /// <summary>
        /// Get the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<IReadOnlyList<string>> GetRequiredStatusChecksContexts(long repositoryId, string branch);

        /// <summary>
        /// Replace the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#replace-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="contexts">The contexts to replace</param>
        Task<IReadOnlyList<string>> UpdateRequiredStatusChecksContexts(string owner, string name, string branch, IReadOnlyList<string> contexts);

        /// <summary>
        /// Replace the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#replace-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="contexts">The contexts to replace</param>
        Task<IReadOnlyList<string>> UpdateRequiredStatusChecksContexts(long repositoryId, string branch, IReadOnlyList<string> contexts);

        /// <summary>
        /// Add the required status checks context for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#add-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="contexts">The contexts to add</param>
        Task<IReadOnlyList<string>> AddRequiredStatusChecksContexts(string owner, string name, string branch, IReadOnlyList<string> contexts);

        /// <summary>
        /// Add the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#add-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="contexts">The contexts to add</param>
        Task<IReadOnlyList<string>> AddRequiredStatusChecksContexts(long repositoryId, string branch, IReadOnlyList<string> contexts);

        /// <summary>
        /// Remove the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="contexts">The contexts to remove</param>
        Task<IReadOnlyList<string>> DeleteRequiredStatusChecksContexts(string owner, string name, string branch, IReadOnlyList<string> contexts);

        /// <summary>
        /// Remove the required status checks contexts for the specified branch
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-required-status-checks-contexts-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="contexts">The contexts to remove</param>
        Task<IReadOnlyList<string>> DeleteRequiredStatusChecksContexts(long repositoryId, string branch, IReadOnlyList<string> contexts);

        /// <summary>
        /// Get restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<BranchProtectionPushRestrictions> GetProtectedBranchRestrictions(string owner, string name, string branch);

        /// <summary>
        /// Get restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#get-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<BranchProtectionPushRestrictions> GetProtectedBranchRestrictions(long repositoryId, string branch);

        /// <summary>
        /// Remove restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<bool> DeleteProtectedBranchRestrictions(string owner, string name, string branch);

        /// <summary>
        /// Remove restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        Task<bool> DeleteProtectedBranchRestrictions(long repositoryId, string branch);

        /// <summary>
        /// Get team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<IReadOnlyList<Team>> GetProtectedBranchTeamRestrictions(string owner, string name, string branch);

        /// <summary>
        /// Get team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<IReadOnlyList<Team>> GetProtectedBranchTeamRestrictions(long repositoryId, string branch);

        /// <summary>
        /// Replace team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#replace-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="teams">List of teams with push access</param>
        Task<IReadOnlyList<Team>> UpdateProtectedBranchTeamRestrictions(string owner, string name, string branch, BranchProtectionTeamCollection teams);

        /// <summary>
        /// Replace team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#replace-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="teams">List of teams with push access to add</param>
        Task<IReadOnlyList<Team>> UpdateProtectedBranchTeamRestrictions(long repositoryId, string branch, BranchProtectionTeamCollection teams);

        /// <summary>
        /// Add team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#add-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="teams">List of teams with push access to add</param>
        Task<IReadOnlyList<Team>> AddProtectedBranchTeamRestrictions(string owner, string name, string branch, BranchProtectionTeamCollection teams);

        /// <summary>
        /// Add team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#add-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="teams">List of teams with push access</param>
        Task<IReadOnlyList<Team>> AddProtectedBranchTeamRestrictions(long repositoryId, string branch, BranchProtectionTeamCollection teams);

        /// <summary>
        /// Remove team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="teams">List of teams to remove</param>
        Task<IReadOnlyList<Team>> DeleteProtectedBranchTeamRestrictions(string owner, string name, string branch, BranchProtectionTeamCollection teams);

        /// <summary>
        /// Remove team restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-team-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="teams">List of teams to remove</param>
        Task<IReadOnlyList<Team>> DeleteProtectedBranchTeamRestrictions(long repositoryId, string branch, BranchProtectionTeamCollection teams);

        /// <summary>
        /// Get user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<IReadOnlyList<User>> GetProtectedBranchUserRestrictions(string owner, string name, string branch);

        /// <summary>
        /// Get user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#list-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        [ExcludeFromPaginationConventionTest]
        Task<IReadOnlyList<User>> GetProtectedBranchUserRestrictions(long repositoryId, string branch);

        /// <summary>
        /// Replace user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#replace-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="users">List of users with push access</param>
        Task<IReadOnlyList<User>> UpdateProtectedBranchUserRestrictions(string owner, string name, string branch, BranchProtectionUserCollection users);

        /// <summary>
        /// Replace user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#replace-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="users">List of users with push access</param>
        Task<IReadOnlyList<User>> UpdateProtectedBranchUserRestrictions(long repositoryId, string branch, BranchProtectionUserCollection users);

        /// <summary>
        /// Add user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#add-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="users">List of users with push access to add</param>
        Task<IReadOnlyList<User>> AddProtectedBranchUserRestrictions(string owner, string name, string branch, BranchProtectionUserCollection users);

        /// <summary>
        /// Add user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#add-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="users">List of users with push access to add</param>
        Task<IReadOnlyList<User>> AddProtectedBranchUserRestrictions(long repositoryId, string branch, BranchProtectionUserCollection users);

        /// <summary>
        /// Remove user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="users">List of users with push access to remove</param>
        Task<IReadOnlyList<User>> DeleteProtectedBranchUserRestrictions(string owner, string name, string branch, BranchProtectionUserCollection users);

        /// <summary>
        /// Remove user restrictions for the specified branch (applies only to Organization owned repositories)
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/branches/#remove-user-restrictions-of-protected-branch">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="branch">The name of the branch</param>
        /// <param name="users">List of users with push access to remove</param>
        Task<IReadOnlyList<User>> DeleteProtectedBranchUserRestrictions(long repositoryId, string branch, BranchProtectionUserCollection users);
    }
}
